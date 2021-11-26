using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo.Models
{
    public partial class DetalleCliente2
    {
        public double? CurrentPeriod { get; set; }
        public double? CustomerId { get; set; }
        public double? PeriodsActive { get; set; }
        public string CurrentCustomerYN { get; set; }
        public double? PeriodAcquired { get; set; }
        public double? PeriodTerminated { get; set; }
        public string AcquisitionChannel { get; set; }
        public string Sector { get; set; }
        public string Region { get; set; }
        public string CoAge { get; set; }
        public string Size { get; set; }
        public double? NoMakerContracts { get; set; }
        public double? NoAdvancedContracts { get; set; }
        public double? RevenueTotal { get; set; }
        public double? MakerRevenue { get; set; }
        public double? AdvancedRevenue { get; set; }
    }
}
