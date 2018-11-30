﻿using System.Collections.Generic;
using SimpleRPGFromScratch.Data.Base;

namespace SimpleRPGFromScratch
{
    public partial class JewelCutQuality : DomainClassBase<JewelCutQuality>
    {
        public static List<double> LegalCutQualityValues = new List<double>{ 0.3, 0.4, 0.5, 0.6, 0.8, 1.0, 1.2, 1.5, 1.8, 2.0, 2.2, 2.5, 3.0};

        public override int GetId()
        {
            return Id;
        }

        public override void SetId(int id)
        {
            Id = id;
        }

        public override void CopyValuesFromObj(JewelCutQuality obj)
        {
            Description = obj.Description;
            Factor = obj.Factor;
        }

        public override void SetInitialValues()
        {
            Factor = 1.0;
        }
    }
}