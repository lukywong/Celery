﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Celery.DynamicProxy
{
    public class DefaultMethodInvocation : IMethodInvocation
    {
        protected object proxy;
        protected MethodInfo method;
        protected object[] parameters;

        public DefaultMethodInvocation(
            object proxy,
            MethodInfo method,
            object[] parameters)
        {
            this.proxy = proxy;
            this.method = method;
            this.parameters = parameters;
        }

        #region IMethodInvocation Members

        public object Proxy
        {
            get { return this.proxy; }
        }

        public MethodInfo Method
        {
            get { return this.method; }
        }

        public object Invoke(object target)
        {
            return this.Method.Invoke(target, parameters);
        }

        #endregion

        #region IInvocation Members

        public object[] Parameters
        {
            get { return this.parameters; }
        }

        #endregion
    }
}
