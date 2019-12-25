﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Core_Attachment> Core_Attachment { get; set; }
        public virtual DbSet<Core_Dict> Core_Dict { get; set; }
        public virtual DbSet<Core_Module> Core_Module { get; set; }
        public virtual DbSet<Core_Role> Core_Role { get; set; }
        public virtual DbSet<Core_RoleModule> Core_RoleModule { get; set; }
        public virtual DbSet<Core_User> Core_User { get; set; }
        public virtual DbSet<Core_UserArea> Core_UserArea { get; set; }
        public virtual DbSet<Core_UserRole> Core_UserRole { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<EvaluationResult> EvaluationResult { get; set; }
        public virtual DbSet<HR_AreaLeader_2016_old> HR_AreaLeader_2016_old { get; set; }
        public virtual DbSet<HR_Comment> HR_Comment { get; set; }
        public virtual DbSet<HR_Course> HR_Course { get; set; }
        public virtual DbSet<HR_Employee> HR_Employee { get; set; }
        public virtual DbSet<HR_Exam> HR_Exam { get; set; }
        public virtual DbSet<HR_Question> HR_Question { get; set; }
        public virtual DbSet<HR_Record> HR_Record { get; set; }
        public virtual DbSet<HR_SMSInfo> HR_SMSInfo { get; set; }
        public virtual DbSet<HR_Teacher> HR_Teacher { get; set; }
        public virtual DbSet<HR_Train> HR_Train { get; set; }
        public virtual DbSet<pwx_dictionary_type> pwx_dictionary_type { get; set; }
        public virtual DbSet<pwx_dictionary_value> pwx_dictionary_value { get; set; }
        public virtual DbSet<pwx_level_info> pwx_level_info { get; set; }
        public virtual DbSet<pwx_sms_verification_code> pwx_sms_verification_code { get; set; }
        public virtual DbSet<pwx_user_energy_consume> pwx_user_energy_consume { get; set; }
        public virtual DbSet<pwx_user_energy_recharge> pwx_user_energy_recharge { get; set; }
        public virtual DbSet<pwx_user_info> pwx_user_info { get; set; }
        public virtual DbSet<pwx_user_photo_info> pwx_user_photo_info { get; set; }
        public virtual DbSet<pwx_user_photo_share> pwx_user_photo_share { get; set; }
        public virtual DbSet<pwx_user_visit_log> pwx_user_visit_log { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<T_cux_hr_all_employee_weixin_v> T_cux_hr_all_employee_weixin_v { get; set; }
        public virtual DbSet<T_ReturnWrite> T_ReturnWrite { get; set; }
        public virtual DbSet<A_EMPLOYEE_WORK_EXPERIENCE_b> A_EMPLOYEE_WORK_EXPERIENCE_b { get; set; }
        public virtual DbSet<A_EMPLOYEE_WORK_EXPERIENCE_h> A_EMPLOYEE_WORK_EXPERIENCE_h { get; set; }
        public virtual DbSet<A_EMPLOYEE_WORK_EXPERIENCE_lead> A_EMPLOYEE_WORK_EXPERIENCE_lead { get; set; }
        public virtual DbSet<A_EMPLOYEE_WORK_EXPERIENCE_lead_top> A_EMPLOYEE_WORK_EXPERIENCE_lead_top { get; set; }
        public virtual DbSet<a_hr_yx_echelon_employee> a_hr_yx_echelon_employee { get; set; }
        public virtual DbSet<A_V_SALES_SERVICERECORD> A_V_SALES_SERVICERECORD { get; set; }
        public virtual DbSet<A_V_SALES_SERVICERECORD1> A_V_SALES_SERVICERECORD1 { get; set; }
        public virtual DbSet<A_V_SALES_SERVICERECORD2> A_V_SALES_SERVICERECORD2 { get; set; }
        public virtual DbSet<Core_UserCity> Core_UserCity { get; set; }
        public virtual DbSet<EvaluationResult_20180206> EvaluationResult_20180206 { get; set; }
        public virtual DbSet<EvaluationResult_New> EvaluationResult_New { get; set; }
        public virtual DbSet<HR_AreaLeader> HR_AreaLeader { get; set; }
        public virtual DbSet<HR_AreaLeader_old_20170901> HR_AreaLeader_old_20170901 { get; set; }
        public virtual DbSet<hr_cric_echelon_employee> hr_cric_echelon_employee { get; set; }
        public virtual DbSet<hr_cric_echelon_name> hr_cric_echelon_name { get; set; }
        public virtual DbSet<HR_CX_Manager_Month_All> HR_CX_Manager_Month_All { get; set; }
        public virtual DbSet<HR_CX_Manager_Month_Area> HR_CX_Manager_Month_Area { get; set; }
        public virtual DbSet<HR_CX_Manager_Month_Project> HR_CX_Manager_Month_Project { get; set; }
        public virtual DbSet<HR_CX_Manager_Quear_All> HR_CX_Manager_Quear_All { get; set; }
        public virtual DbSet<HR_CX_Manager_Quear_Area> HR_CX_Manager_Quear_Area { get; set; }
        public virtual DbSet<HR_CX_Manager_Year_All> HR_CX_Manager_Year_All { get; set; }
        public virtual DbSet<HR_CX_Manager_Year_Area> HR_CX_Manager_Year_Area { get; set; }
        public virtual DbSet<HR_CX_Manager_Year_Project> HR_CX_Manager_Year_Project { get; set; }
        public virtual DbSet<HR_Data_AreaDDMonthAVGForYear> HR_Data_AreaDDMonthAVGForYear { get; set; }
        public virtual DbSet<HR_Data_AreaDDQuarterAVGForYear> HR_Data_AreaDDQuarterAVGForYear { get; set; }
        public virtual DbSet<HR_Data_AreaDDYearAVGForYear> HR_Data_AreaDDYearAVGForYear { get; set; }
        public virtual DbSet<HR_Data_PeopleDDSumListForYear> HR_Data_PeopleDDSumListForYear { get; set; }
        public virtual DbSet<HR_Data_ProjectDDMonthAVGForYear> HR_Data_ProjectDDMonthAVGForYear { get; set; }
        public virtual DbSet<HR_Data_ProjectDDQuarterAVGForYear> HR_Data_ProjectDDQuarterAVGForYear { get; set; }
        public virtual DbSet<HR_Data_ProjectDDYearAVGForYear> HR_Data_ProjectDDYearAVGForYear { get; set; }
        public virtual DbSet<HR_Data_ProjectRaking> HR_Data_ProjectRaking { get; set; }
        public virtual DbSet<HR_DD_Manager_Month_All> HR_DD_Manager_Month_All { get; set; }
        public virtual DbSet<HR_DD_Manager_Month_Area> HR_DD_Manager_Month_Area { get; set; }
        public virtual DbSet<HR_DD_Manager_Month_Project> HR_DD_Manager_Month_Project { get; set; }
        public virtual DbSet<HR_DD_Manager_Quear_All> HR_DD_Manager_Quear_All { get; set; }
        public virtual DbSet<HR_DD_Manager_Quear_Area> HR_DD_Manager_Quear_Area { get; set; }
        public virtual DbSet<HR_DD_Manager_Year_All> HR_DD_Manager_Year_All { get; set; }
        public virtual DbSet<HR_DD_Manager_Year_Area> HR_DD_Manager_Year_Area { get; set; }
        public virtual DbSet<HR_DD_Manager_Year_Project> HR_DD_Manager_Year_Project { get; set; }
        public virtual DbSet<HR_etl_employee_info> HR_etl_employee_info { get; set; }
        public virtual DbSet<HR_Teacher_2017> HR_Teacher_2017 { get; set; }
        public virtual DbSet<HR_Teacher_Select> HR_Teacher_Select { get; set; }
        public virtual DbSet<hr_yx_echelon_employee> hr_yx_echelon_employee { get; set; }
        public virtual DbSet<hr_yx_echelon_name> hr_yx_echelon_name { get; set; }
        public virtual DbSet<jianli_Education_Experience> jianli_Education_Experience { get; set; }
        public virtual DbSet<jianli_Employee_Information> jianli_Employee_Information { get; set; }
        public virtual DbSet<jianli_Work_Experience> jianli_Work_Experience { get; set; }
        public virtual DbSet<ProjectPeopleNum> ProjectPeopleNum { get; set; }
        public virtual DbSet<ProjectPeopleNum_Area> ProjectPeopleNum_Area { get; set; }
        public virtual DbSet<T_etl_employee_info> T_etl_employee_info { get; set; }
        public virtual DbSet<T_Logs_Teacher> T_Logs_Teacher { get; set; }
        public virtual DbSet<T_PlaceRank> T_PlaceRank { get; set; }
        public virtual DbSet<T_PlaceSalesNum> T_PlaceSalesNum { get; set; }
        public virtual DbSet<T_ProjectRank> T_ProjectRank { get; set; }
        public virtual DbSet<T_SYBRank> T_SYBRank { get; set; }
        public virtual DbSet<Teacher_Select> Teacher_Select { get; set; }
        public virtual DbSet<userinfo_expand_record> userinfo_expand_record { get; set; }
    }
}