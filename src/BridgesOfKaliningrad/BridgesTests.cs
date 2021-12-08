using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgesOfKaliningrad;

[TestClass]
public class BridgesTests
{

	[TestMethod]
	public void Test()
	{
		Assert.IsTrue(Bridges.BridgesAreValid(
			"#-#"
		));

		Assert.IsTrue(Bridges.BridgesAreValid(
			"#-#\n" +
			"|\n" +
			"#"
		));

		Assert.IsFalse(Bridges.BridgesAreValid(
			"#\n" +
			"|\n" +
			"#-#\n" +
			"|\n" +
			"#"
		));

		Assert.IsTrue(Bridges.BridgesAreValid(
			"######\n" +
			"| ### \n" +
			"|   | \n" +
			"##  ##\n"
		));

		Assert.IsTrue(Bridges.BridgesAreValid(
			"####  #\n" +
			" ##--##\n" +
			" |   # \n" +
			"##   ##\n" +
			" ###-##\n"
		));

		Assert.IsTrue(Bridges.BridgesAreValid(
			"###  \n" +
			" ### \n" +
			" | | \n" +
			"##-# \n" +
			"|  ##\n" +
			"##  #\n"
		));

		Assert.IsFalse(Bridges.BridgesAreValid(
			"##########\n" +
			" |  |   | \n" +
			"###### ###\n" +
			"######-###\n" +
			" |  |   | \n" +
			"##########"
		));

		Assert.IsFalse(Bridges.BridgesAreValid(
			"#####         ####\n" +
			" #########--### | \n" +
			"    ####    |   | \n" +
			"#     |     #   ##\n" +
			"#     |     ##  ##\n" +
			"##----###      ###\n" +
			" ##  #######---## \n"
		));

		Assert.IsFalse(Bridges.BridgesAreValid(
			"#####         ####\n" +
			" #########--### | \n" +
			"    ####    |   | \n" +
			"#     |     #   ##\n" +
			"#     |     ##--##\n" +
			"##----###      ###\n" +
			" ##  #######---## \n"
		));
	}

}
