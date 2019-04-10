﻿using System;
using System.Linq;

namespace MySoftLog.Model.DT0
{
    /// <summary>
    /// 数据对象基类
    /// </summary>
    [Serializable]
    public class DTOBase
    {
        /// <summary>
        /// 获取属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <returns></returns>
        public virtual T GetValue<T>(string property)
        {
            var prop = this.GetType().GetProperties()
                .FirstOrDefault(q => q.CanRead&&
                                     string.CompareOrdinal(q.Name, property) ==0);
            return prop == null ? default(T) : (T)prop.GetValue(this);
        }
    }
}