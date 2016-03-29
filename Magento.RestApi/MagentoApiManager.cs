namespace Magento.RestApi
{
    public class MagentoApiManager
    {
        public Models.ApiSettings Settings { get; protected set; }
        public MagentoApi ApiClient { get; protected set; }
        public bool AccessTokensChanges { get; protected set; }

        public MagentoApiManager(Models.ApiSettings settings)
        {
            this.Settings = settings;
            this.Initialize();
        }
        /// <summary>
        /// constructor to manually pass in all settings individually
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <param name="accessKey"></param>
        /// <param name="accessSecret"></param>
        /// <param name="healthcheckItemId"></param>
        public MagentoApiManager(string url, string userName, string password, string consumerKey, string consumerSecret, string accessKey, string accessSecret, int healthcheckItemId)
        {
            this.Settings = new Models.ApiSettings
            {
                Url = url,
                UserName = userName,
                Password = password,
                ConsumerKey = consumerKey,
                ConsumerSecret = consumerSecret,
                AccessKey = accessKey,
                AccessSecret = accessSecret,
                HealthcheckItemId = healthcheckItemId
            };
        }

        protected void Initialize()
        {
            this.ApiClient = new MagentoApi();
            this.ApiClient.Initialize(this.Settings.Url, this.Settings.ConsumerKey, this.Settings.ConsumerSecret)
                .SetAccessToken(this.Settings.AccessKey, this.Settings.AccessSecret);

            if (this.TestConnection()) return;

            this.Authenticate();
        }

        protected bool Authenticate()
        {
            this.ApiClient.AuthenticateAdmin(this.Settings.UserName, this.Settings.Password);

            this.Settings.AccessKey = this.ApiClient.AccessTokenKey;
            this.Settings.AccessSecret = this.ApiClient.AccessTokenSecret;

            this.AccessTokensChanges = true;

            return this.TestConnection();
        }

        

        public bool TestConnection()
        {
            var resultTask = this.ApiClient.GetWebsitesForProduct(this.Settings.HealthcheckItemId);
            resultTask.Wait();

            return !resultTask.Result.HasErrors;
        }
    }
}
