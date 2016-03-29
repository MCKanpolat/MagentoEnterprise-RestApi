using System.Collections.Generic;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// 
        /// </summary>
        public Filter()
        {
            this.Page = 1;
            this.PageSize = 10;
            this.SortDirection = SortDirection.asc;
            this.FilterExpressions = new List<FilterExpression>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SortDirection SortDirection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SortField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FilterExpression> FilterExpressions { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        asc,
        /// <summary>
        /// 
        /// </summary>
        desc
    }
}
