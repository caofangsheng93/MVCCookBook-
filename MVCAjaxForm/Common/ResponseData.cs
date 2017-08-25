using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAjaxForm.Common
{
    /// <summary>
    /// 返回Json格式的数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseData<T>
    {
        public T Data { get; set; }

        public string RedirectURL { get; set; }

        public bool IsSuccess { get { return this.Data == null; } }
    }
}