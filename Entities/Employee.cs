﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            DashboardWidgets = new HashSet<DashboardWidget>();
            EmployeeDrawers = new HashSet<EmployeeDrawer>();
            EmployeeRates = new HashSet<EmployeeRate>();
            MenuUsages = new HashSet<MenuUsage>();
            _ReportParameterValues = new HashSet<_ReportParameterValue>();
        }

        public Guid EmployeeID { get; set; }
        public int StoreID { get; set; }
        public short EmpID { get; set; }
        public short OldPassword { get; set; }
        public short SecurityLevel { get; set; }
        public string? Badge { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleInitial { get; set; }
        public short Class { get; set; }
        public short PriceLevel { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? UserInfo { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public byte[]? SSN { get; set; }
        public string? IceName { get; set; }
        public string? IcePhone { get; set; }
        public byte GSLFirstRoom { get; set; }
        public byte GSLCurrRoom { get; set; }
        public byte IsInactive { get; set; }
        public short UpperLeftX { get; set; }
        public short UpperLeftY { get; set; }
        public byte WindowOrientation { get; set; }
        public bool FingerprintRequiresId { get; set; }
        public string? Address { get; set; }
        public byte[]? FingerPrintData { get; set; }
        public byte[]? FrontEndPassword { get; set; }
        public byte[]? BackOfficePassword1 { get; set; }
        public byte[]? BackOfficePassword2 { get; set; }
        public byte[]? BackOfficePassword3 { get; set; }
        public byte[]? BackOfficePassword4 { get; set; }
        public DateTime? PasswordChanged { get; set; }
        public byte BadPasswordCount { get; set; }
        public DateTime? LockedOut { get; set; }
        public bool NeedEncrypted { get; set; }
        public DateTime? LastBadPWDate { get; set; }
        public bool RequireFingerprintForClockInOut { get; set; }
        public string? Email { get; set; }
        public string? CellPhone { get; set; }
        public int CellProvider { get; set; }
        public int AlertPreference { get; set; }
        public bool IsClockInExempt { get; set; }
        public byte[]? Salt { get; set; }
        public byte[]? FrontEndHash { get; set; }
        public byte[]? BackOfficeHash1 { get; set; }
        public byte[]? BackOfficeHash2 { get; set; }
        public byte[]? BackOfficeHash3 { get; set; }
        public byte[]? BackOfficeHash4 { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string? Notes { get; set; }
        public int? UserInviteStatus { get; set; }
        public bool IsBackOfficeUser { get; set; }
        public int Language { get; set; }
        public int? CloudUserInviteStatus { get; set; }
        public bool IsCloudUser { get; set; }

        public virtual ICollection<DashboardWidget> DashboardWidgets { get; set; }
        public virtual ICollection<EmployeeDrawer> EmployeeDrawers { get; set; }
        public virtual ICollection<EmployeeRate> EmployeeRates { get; set; }
        public virtual ICollection<MenuUsage> MenuUsages { get; set; }
        public virtual ICollection<_ReportParameterValue> _ReportParameterValues { get; set; }
    }
}
