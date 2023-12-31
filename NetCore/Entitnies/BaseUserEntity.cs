﻿using NetCore.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entitnies
{
    [Table("Base_User")]
    public class BaseUserEntity : BaseEntity
    {
        #region 实体成员
        /// <summary>
        /// 用户主键
        /// </summary>		
        public string UserId { get; set; }
        /// <summary>
        /// TeamNo
        /// </summary>
        /// <returns></returns>
        public string TeamNo { get; set; }
        /// <summary>
        /// 用户编码
        /// </summary>		
        public string EnCode { get; set; }
        /// <summary>
        /// 登录账户
        /// </summary>		
        public string Account { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>		
        public string Password { get; set; }
        /// <summary>
        /// 密码秘钥
        /// </summary>		
        public string Secretkey { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>		
        public string RealName { get; set; }
        /// <summary>
        /// 呢称
        /// </summary>
        [NotNull]
        public string NickName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>		
        public string HeadIcon { get; set; }
        /// <summary>
        /// 快速查询
        /// </summary>		
        public string QuickQuery { get; set; }
        /// <summary>
        /// 简拼
        /// </summary>		
        public string SimpleSpelling { get; set; }
        /// <summary>
        /// 性别
        /// </summary>		
        public int? Gender { get; set; }
        /// <summary>
        /// 生日
        /// </summary>		
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 手机
        /// </summary>		
        public string Mobile { get; set; }
        /// <summary>
        /// 电话
        /// </summary>		
        public string Telephone { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>		
        public string Email { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>		
        public string OICQ { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>		
        public string WeChat { get; set; }
        /// <summary>
        /// MSN
        /// </summary>		
        public string MSN { get; set; }
        /// <summary>
        /// 主管主键
        /// </summary>		
        public string ManagerId { get; set; }
        /// <summary>
        /// 主管
        /// </summary>		
        public string Manager { get; set; }
        /// <summary>
        /// 机构主键
        /// </summary>		
        public string OrganizeId { get; set; }
        /// <summary>
        /// 部门主键
        /// </summary>		
        public string DepartmentId { get; set; }
        /// <summary>
        /// 角色主键
        /// </summary>		
        public string RoleId { get; set; }
        /// <summary>
        /// 岗位主键
        /// </summary>		
        public string DutyId { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>		
        public string DutyName { get; set; }
        /// <summary>
        /// 职位主键
        /// </summary>		
        public string PostId { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>		
        public string PostName { get; set; }
        /// <summary>
        /// 工作组主键
        /// </summary>		
        public string WorkGroupId { get; set; }
        /// <summary>
        /// 安全级别
        /// </summary>		
        public int? SecurityLevel { get; set; }
        /// <summary>
        /// 在线状态
        /// </summary>		
        public int? UserOnLine { get; set; }
        /// <summary>
        /// 单点登录标识
        /// </summary>		
        public int? OpenId { get; set; }
        /// <summary>
        /// IsTeamSystem
        /// </summary>		
        public int? IsTeamSystem { get; set; }
        /// <summary>
        /// 密码提示问题
        /// </summary>		
        public string Question { get; set; }
        /// <summary>
        /// 密码提示答案
        /// </summary>		
        public string AnswerQuestion { get; set; }
        /// <summary>
        /// 允许多用户同时登录
        /// </summary>		
        public int? CheckOnLine { get; set; }
        /// <summary>
        /// 允许登录时间开始
        /// </summary>		
        public DateTime? AllowStartTime { get; set; }
        /// <summary>
        /// 允许登录时间结束
        /// </summary>		
        public DateTime? AllowEndTime { get; set; }
        /// <summary>
        /// 暂停用户开始日期
        /// </summary>		
        public DateTime? LockStartDate { get; set; }
        /// <summary>
        /// 暂停用户结束日期
        /// </summary>		
        public DateTime? LockEndDate { get; set; }
        /// <summary>
        /// 第一次访问时间
        /// </summary>		
        public DateTime? FirstVisit { get; set; }
        /// <summary>
        /// 上一次访问时间
        /// </summary>		
        public DateTime? PreviousVisit { get; set; }
        /// <summary>
        /// 最后访问时间
        /// </summary>		
        public DateTime? LastVisit { get; set; }
        /// <summary>
        /// 客户端缓存时间
        /// </summary>		
        public DateTime? ClientCacheTime { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>		
        public int? LogOnCount { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>		
        public int? SortCode { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>		
        public int? DeleteMark { get; set; }
        /// <summary>
        /// 有效标志
        /// </summary>		
        public int? EnabledMark { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        public string Description { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>		
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>		
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>		
        public string CreateUserName { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>		
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 修改用户主键
        /// </summary>		
        public string ModifyUserId { get; set; }
        /// <summary>
        /// 修改用户
        /// </summary>		
        public string ModifyUserName { get; set; }

        // 总店id
        public int TeamId { get; set; }
        /// <summary>
        /// WxOpenId
        /// </summary>		
        public string WxOpenId { get; set; }
        /// <summary>
        /// WxUnionOpenId
        /// </summary>		
        public string WxUnionOpenId { get; set; }
        /// <summary>
        /// 绑定会员编号
        /// </summary>		
        public string BindMemberId { get; set; }
        /// <summary>
        /// 是否可接受消息
        /// </summary>		
        public int? IsReceivePayMsg { get; set; }
        /// <summary>
        /// 是否可核销优惠券
        /// </summary>	
        public int? IsOrgCheckVoucherManager { get; set; }
        /// <summary>
        /// 是否可审核合同
        /// </summary>	
        public int? IsAuditContact { get; set; }
        /// <summary>
        /// 是否可核销优惠券
        /// </summary>	
        public int? IsEditPrice { get; set; }

        /// <summary>
        /// 公司名称Id
        /// </summary>	
        public string CompanyId { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>		
        public string CompanyName { get; set; }
       
        #endregion
    }
}
