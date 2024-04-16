using DataNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests;

public class DataAbstractAPITest
{
    [Test]
    public void CreateApiTest()
    {
        Assert.IsInstanceOf(typeof(DataAbstractAPI), DataAbstractAPI.CreateApi());
    }
}