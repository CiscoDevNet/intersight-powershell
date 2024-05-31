using Intersight.Model;
using Intersight.PowerShell;
using System.Xml;

namespace Intersight.PowerShellTest
{
    [TestClass]
    public class PSUtilsTest
    {
        [TestMethod]
        public void TestCompareIntersightObjectNtpPolicy()
        {

            var xNtpPolicy = new NtpPolicy();
            xNtpPolicy.Name = "TestNtp";
            xNtpPolicy.Description = "test compare";
            xNtpPolicy.Enabled = true;
            xNtpPolicy.NtpServers = new List<string> { "11.11.11.11", "34.34.34.34", "55.55.55.55" };

            var yNtpPolicy = new NtpPolicy();
            yNtpPolicy.Name = "TestNtp";
            yNtpPolicy.Description = "test compare";
            yNtpPolicy.Enabled = true;
            yNtpPolicy.NtpServers = new List<string> { "11.11.11.11", "34.34.34.34", "55.55.55.55" };

            Assert.IsTrue(PSUtils.CompareIntersightObject(xNtpPolicy, yNtpPolicy));

        }

        [TestMethod]
        public void TestCompareIntersightObjectNtpPolicyNegative()
        {
            var xNtpPolicy = new NtpPolicy();
            xNtpPolicy.Name = "TestNtp";
            xNtpPolicy.Description = "test compare";
            xNtpPolicy.Enabled = true;
            xNtpPolicy.NtpServers = new List<string> { "11.11.11.11", "34.34.34.34", "55.55.55.55" };

            var yNtpPolicy = new NtpPolicy();
            yNtpPolicy.Name = "TestNtp";
            yNtpPolicy.Description = "test compare";
            yNtpPolicy.Enabled = true;
            yNtpPolicy.NtpServers = new List<string> { "11.11.11.11", "55.55.55.55", "34.34.34.34" };

            Assert.IsFalse(PSUtils.CompareIntersightObject(xNtpPolicy, yNtpPolicy));

        }

        [TestMethod]
        public void TestCompareIntersightObjectOrganization()
        {
            var xOrganization = new OrganizationOrganization();
            xOrganization.Name = "Organization";
            xOrganization.Description = "test compare";
            xOrganization.Moid = "1bxde76666666";


            var yOrganization = new OrganizationOrganization();
            yOrganization.Name = "Organization";
            yOrganization.Description = "test compare";
            yOrganization.Moid = "1bxde76666666";

            Assert.IsTrue(PSUtils.CompareIntersightObject(xOrganization, yOrganization));

        }

        [TestMethod]
        public void TestCompareIntersightObjectOrganizationNegative()
        {
            var xOrganization = new OrganizationOrganization();
            xOrganization.Name = "Organization";
            xOrganization.Description = "test compare";
            xOrganization.Moid = "1bxde76666666";


            var yOrganization = new OrganizationOrganization();
            yOrganization.Name = "Organization";
            yOrganization.Description = "test compar";
            yOrganization.Moid = "1bxd";

            Assert.IsFalse(PSUtils.CompareIntersightObject(xOrganization, yOrganization));
        }

        [TestMethod]
        public void TestCompareIntersightObjectBootPrecisionPolicy()
        {
            var xBootPrecision = new BootPrecisionPolicy();
            xBootPrecision.Name = "BootPrecisionPolicy";
            xBootPrecision.Description = "Boot precision description";
            xBootPrecision.Moid = "a1234567cbea";
            xBootPrecision.BootDevices = new List<BootDeviceBase>
            {
                new BootPxe
                {
                    Name = "ias-pxe",
                    Enabled = true,
                    ClassId = BootPxe.ClassIdEnum.BootPxe,
                    ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                    AdditionalProperties = new Dictionary<string, object>
                    {
                        {"InterfaceName","eth0" },
                        {"InterfaceSource","name" },
                        {"IpType","IPv4" },
                        {"Port",-1 },
                        {"Slot","L" }
                    }
                },
                new BootVirtualMedia
                {
                    Name = "vmedia",
                    Enabled = true,
                    ClassId = BootVirtualMedia.ClassIdEnum.BootVirtualMedia,
                    ObjectType = BootVirtualMedia.ObjectTypeEnum.BootVirtualMedia
                }
            };

            var yBootPrecision = new BootPrecisionPolicy();
            yBootPrecision.Name = "BootPrecisionPolicy";
            yBootPrecision.Description = "Boot precision description";
            yBootPrecision.Moid = "a1234567cbea";
            yBootPrecision.BootDevices = new List<BootDeviceBase>
            {
                new BootPxe
                {
                    Name = "ias-pxe",
                    Enabled = true,
                    ClassId = BootPxe.ClassIdEnum.BootPxe,
                    ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                    AdditionalProperties = new Dictionary<string, object>
                    {
                        {"InterfaceName","eth0" },
                        {"InterfaceSource","name" },
                        {"IpType","IPv4" },
                        {"Port",-1 },
                        {"Slot","L" }
                    }
                },
                new BootVirtualMedia
                {
                    Name = "vmedia",
                    Enabled = true,
                    ClassId = BootVirtualMedia.ClassIdEnum.BootVirtualMedia,
                    ObjectType = BootVirtualMedia.ObjectTypeEnum.BootVirtualMedia
                }
            };

            Assert.IsTrue(PSUtils.CompareIntersightObject(xBootPrecision, yBootPrecision));
        }

        [TestMethod]
        public void TestCompareIntersightObjectBootPrecisionPolicyNegative()
        {
            var xBootPrecision = new BootPrecisionPolicy();
            xBootPrecision.Name = "BootPrecisionPolicy";
            xBootPrecision.Description = "Boot precision description";
            xBootPrecision.Moid = "a1234567cbea";
            xBootPrecision.BootDevices = new List<BootDeviceBase>
            {
                new BootPxe
                {
                    Name = "ias-pxe",
                    Enabled = true,
                    ClassId = BootPxe.ClassIdEnum.BootPxe,
                    ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                    AdditionalProperties = new Dictionary<string, object>
                    {
                        {"InterfaceName","eth0" },
                        {"InterfaceSource","name" },
                        {"IpType","IPv4" },
                        {"Port",-1 },
                        {"Slot","L" }
                    }
                },
                new BootVirtualMedia
                {
                    Name = "vmedia",
                    Enabled = true,
                    ClassId = BootVirtualMedia.ClassIdEnum.BootVirtualMedia,
                    ObjectType = BootVirtualMedia.ObjectTypeEnum.BootVirtualMedia
                }
            };

            var yBootPrecision = new BootPrecisionPolicy();
            yBootPrecision.Name = "BootPrecisionPolicy";
            yBootPrecision.Description = "Boot precision description";
            yBootPrecision.Moid = "a1234567cbea";
            yBootPrecision.BootDevices = new List<BootDeviceBase>
            {
                new BootPxe
                {
                    Name = "ias-pxe",
                    Enabled = true,
                    ClassId = BootPxe.ClassIdEnum.BootPxe,
                    ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                    AdditionalProperties = new Dictionary<string, object>
                    {
                        {"InterfaceName","eth0" },
                        {"InterfaceSource","name" },
                        {"IpType","IPv4" },
                        {"Port",-1 },
                        {"Slot","L" }
                    }
                },
                new BootVirtualMedia
                {
                    Name = "vmedia",
                    Enabled = true,
                    ClassId = BootVirtualMedia.ClassIdEnum.BootVirtualMedia,
                    ObjectType = BootVirtualMedia.ObjectTypeEnum.BootVirtualMedia
                },
                new BootSan
                {
                    Name = "fc0",
                    Enabled = true,
                    ClassId = BootSan.ClassIdEnum.BootSan,
                    ObjectType = BootSan.ObjectTypeEnum.BootSan,
                    AdditionalProperties = new Dictionary<string, object>
                    {
                        {"Lun",0 },
                        {"Slot","MLOM" }
                    }
                }
            };

            Assert.IsFalse(PSUtils.CompareIntersightObject(xBootPrecision, yBootPrecision));
        }

        [TestMethod]
        public void TestCompareListInt()
        {
            var xList = new List<int> { 1, 3, 5, 6, 7 };
            var yList = new List<int> { 1, 3, 5, 6, 7 };
            Assert.IsTrue(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListIntNegative()
        {
            var xList = new List<int> { 1, 3, 5, 6, 7 };
            var yList = new List<int> { 1, 3, 5, 6, 9 };
            Assert.IsFalse(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListBool()
        {
            var xList = new List<bool> { true, false, true, true, true };
            var yList = new List<bool> { true, false, true, true, true };
            Assert.IsTrue(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListString()
        {
            var xList = new List<string> { "11.11.11.11", "22.22.22.22", "33.33.33.33" };
            var yList = new List<string> { "11.11.11.11", "22.22.22.22", "33.33.33.33" };
            Assert.IsTrue(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListStringNegative()
        {
            var xList = new List<string> { "11.11.11.11", "22.22.22.11", "33.33.33.33" };
            var yList = new List<string> { "11.11.11.11", "22.22.22.22", "33.33.33.33" };
            Assert.IsFalse(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListMoref()
        {
            var xList = new List<OrganizationOrganizationRelationship>
            {
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"1234abc")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"abc123456")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"ef123456")
                }
            };
            var yList = new List<OrganizationOrganizationRelationship>
            {
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"1234abc")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"abc123456")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"ef123456")
                }

        };
            Assert.IsTrue(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListMorefNegative()
        {
            var xList = new List<OrganizationOrganizationRelationship>
            {
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"c234abc")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"abc123456")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"ef126456")
                }
            };
            var yList = new List<OrganizationOrganizationRelationship>
            {
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"1234abc")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"abc123456")
                },
                new OrganizationOrganizationRelationship
                {
                    ActualInstance = new MoMoRef(MoMoRef.ClassIdEnum.MoMoRef,MoMoRef.ObjectTypeEnum.OrganizationOrganization,"ef123456")
                }

        };
            Assert.IsFalse(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListForBootDevice()
        {
            var xList = new List<BootDeviceBase>();
            xList.Add(new BootPxe
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                ClassId = BootPxe.ClassIdEnum.BootPxe
            });

            xList.Add(new BootSan
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootSan.ObjectTypeEnum.BootSan,
                ClassId = BootSan.ClassIdEnum.BootSan,
                Slot = "MLOM",
                Lun = 1
            });

            var yList = new List<BootDeviceBase>();
            yList.Add(new BootPxe
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                ClassId = BootPxe.ClassIdEnum.BootPxe
            });

            yList.Add(new BootSan
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootSan.ObjectTypeEnum.BootSan,
                ClassId = BootSan.ClassIdEnum.BootSan,
                Slot = "MLOM",
                Lun = 1
            });
            Assert.IsTrue(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListForBootDeviceNegative()
        {
            var xList = new List<BootDeviceBase>();
            xList.Add(new BootPxe
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                ClassId = BootPxe.ClassIdEnum.BootPxe
            });

            xList.Add(new BootSan
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootSan.ObjectTypeEnum.BootSan,
                ClassId = BootSan.ClassIdEnum.BootSan,
                Slot = "MLOM",
                Lun = 1
            });

            var yList = new List<BootDeviceBase>();
            yList.Add(new BootPxe
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                ClassId = BootPxe.ClassIdEnum.BootPxe
            });

            yList.Add(new BootSan
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootSan.ObjectTypeEnum.BootSan,
                ClassId = BootSan.ClassIdEnum.BootSan,
                Slot = "MLOM",
                Lun = 1
            });
            yList.Add(new BootLocalCdd
            {
                Name = "bootLocalCdd",
                Enabled = true,
                ObjectType = BootDeviceBase.ObjectTypeEnum.BootLocalCdd,
                ClassId = BootDeviceBase.ClassIdEnum.BootLocalCdd
            });
            Assert.IsFalse(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListForBootDeviceNegative2()
        {
            var xList = new List<BootDeviceBase>();
            xList.Add(new BootPxe
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                ClassId = BootPxe.ClassIdEnum.BootPxe
            });

            xList.Add(new BootSan
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootSan.ObjectTypeEnum.BootSan,
                ClassId = BootSan.ClassIdEnum.BootSan,
                Slot = "MLOM",
                Lun = 1
            });

            var yList = new List<BootDeviceBase>();
            yList.Add(new BootPxe
            {
                Name = "bootPxe",
                Enabled = true,
                InterfaceName = "testInterface",
                ObjectType = BootPxe.ObjectTypeEnum.BootPxe,
                ClassId = BootPxe.ClassIdEnum.BootPxe
            });

            yList.Add(new BootLocalCdd
            {
                Name = "bootLocalCdd",
                Enabled = true,
                ObjectType = BootDeviceBase.ObjectTypeEnum.BootLocalCdd,
                ClassId = BootDeviceBase.ClassIdEnum.BootLocalCdd
            });
            Assert.IsFalse(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListMoTag()
        {
            var xList = new List<MoTag>
            {
                new MoTag{Key = "Country", Value = "India"},
                new MoTag{Key = "ServerType", Value = "Hx"},
                new MoTag{Key = "os.Intersight", Value = "Vmware"}
            };

            var yList = new List<MoTag>
            {
                new MoTag{Key = "Country", Value = "India"},
                new MoTag{Key = "ServerType", Value = "Hx"},
                new MoTag{Key = "os.Intersight", Value = "Vmware"}
            };

            Assert.IsTrue(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareListMoTagNegative()
        {
            var xList = new List<MoTag>
            {
                new MoTag{Key = "Country", Value = "India"},
                new MoTag{Key = "ServerType", Value = "Hx"},
                new MoTag{Key = "os.Intersight", Value = "Vmware"}
            };

            var yList = new List<MoTag>
            {
                new MoTag{Key = "Country", Value = "India"},
                new MoTag{Key = "ServerType", Value = "Nutanix"},
                new MoTag{Key = "os.Intersight", Value = "Vmware"}
            };

            Assert.IsFalse(PSUtils.CompareList(xList, yList));
        }

        [TestMethod]
        public void TestCompareDictionary()
        {
            var xDict = new Dictionary<string, string>();
            xDict.Add("Name", "Powershell");
            xDict.Add("Environment", "Production");
            xDict.Add("User", "Internal");


            var yDict = new Dictionary<string, string>();
            yDict.Add("Name", "Powershell");
            yDict.Add("Environment", "Production");
            yDict.Add("User", "Internal");

            Assert.IsTrue(PSUtils.CompareDictionary(xDict, yDict));
        }

        [TestMethod]
        public void TestCompareDictionaryNegative()
        {
            var xDict = new Dictionary<string, string>();
            xDict.Add("Name", "Powershell");
            xDict.Add("Environment", "Production");
            xDict.Add("User", "Internal");


            var yDict = new Dictionary<string, string>();
            yDict.Add("Name", "Powershell");
            yDict.Add("Environment", "xxxxxx");
            yDict.Add("User", "Internal");

            Assert.IsFalse(PSUtils.CompareDictionary(xDict, yDict));
        }

        [TestMethod]
        public void TestCompareDictionaryComplexObject()
        {
            var xDict = new Dictionary<string, object>();
            xDict.Add("Item1", new MoMoRef { ClassId = MoMoRef.ClassIdEnum.MoMoRef, ObjectType = MoMoRef.ObjectTypeEnum.NtpPolicy, Moid = "abc12345" });
            xDict.Add("Item2", new NtpPolicy { Name = "NtpPlocy", NtpServers = new List<string> { "22.22.22.22" }, Enabled = true });

            var yDict = new Dictionary<string, object>();
            yDict.Add("Item1", new MoMoRef { ClassId = MoMoRef.ClassIdEnum.MoMoRef, ObjectType = MoMoRef.ObjectTypeEnum.NtpPolicy, Moid = "abc12345" });
            yDict.Add("Item2", new NtpPolicy { Name = "NtpPlocy", NtpServers = new List<string> { "22.22.22.22" }, Enabled = true });

            Assert.IsTrue(PSUtils.CompareDictionary(xDict, yDict));
        }
    }
}