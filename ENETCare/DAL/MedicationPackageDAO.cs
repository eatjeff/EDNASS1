﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETCare.Business
{
	public interface MedicationPackageDAO
	{
		List<MedicationPackage> FindAllPackages();
		List<MedicationPackage> FindPackagesInDistributionCentre(int distributionCentreId);
		MedicationPackage FindPackageByBarcode(string barcode);
		void InsertPackage(MedicationPackage package);
		void UpdatePackage(MedicationPackage package);
	}
}
