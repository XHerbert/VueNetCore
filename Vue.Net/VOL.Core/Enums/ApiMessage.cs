using System;
using System.Collections.Generic;
using System.Text;

namespace VOL.Core.Enums
{
    public struct ApiMessage
    {

        /// <summary>
        /// 参数有误
        /// </summary>
        public const string ParameterError = "请求参数不正确!";

        /// <summary>
        /// 没有配置好输入参数
        /// </summary>
        public const string NotInputEntity = "没有配置好输入参数!";

        /// <summary>
        /// token丢失
        /// </summary>
        public const string TokenLose = "token丢失!";

        /// <summary>
        /// 版本号不能为空
        /// </summary>
        public const string VersionEmpty = "版本号不能为空!";

        /// <summary>
        /// content不能为空
        /// </summary>
        public const string ContentEmpty = "biz_content不能为空!";

        /// <summary>
        /// content不能为空
        /// </summary>
        public const string TokenError = "token不正确";

        /// <summary>
        /// 帐号已被锁定
        /// </summary>
        public const string AccountLocked = "帐号已被锁定!";

        /// <summary>
        /// 输入的不是手机号
        /// </summary>
        public const string PhoneNoInvalid = "输入的不是手机号";

        /// <summary>
        /// 获取验证的类型不正确
        /// </summary>
        public const string PINTypeNotRange = "获取验证的类型不正确";

        /// <summary>
        /// 操作太频繁，请稍后再试
        /// </summary>
        public const string OperTooBusy = "操作太频繁，请稍后再试";

        /// <summary>
        /// 短信发送异常,请稍后再试
        /// </summary>
        public const string SendSTKError = "短信发送异常,请稍后再试";

        /// <summary>
        /// 短信发送成功
        /// </summary>
        public const string SendSTKSuccess = "短信发送成功";

        /// <summary>
        /// 请先获取验证码
        /// </summary>
        public const string STKNotSend = "请先获取验证码";

        /// <summary>
        /// 手机号已经被注册
        /// </summary>
        public const string AccountExists = "手机号已经被注册";

        /// <summary>
        /// 手机号没有注册
        /// </summary>
        public const string AccountNotExists = "手机号没有注册";

        /// <summary>
        /// 验证码已过期,请重新获取
        /// </summary>
        public const string PINExpire = "验证码已过期,请重新获取";

        /// <summary>
        /// 验证码不正确
        /// </summary>
        public const string PINError = "验证码不正确";

        /// <summary>
        /// 参数不能为空
        /// </summary>
        public const string ParameterEmpty = "参数不能为空";
    }
}
