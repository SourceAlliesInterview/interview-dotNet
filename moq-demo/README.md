
# [moq][1] demo

 
Code example demonstrating the use of [moq][1] and [NUnit][3]. 
 
![Moq][2]


    :::C#
		var mock = new Mock<ILoveThisFramework>();

		// WOW! No record/replay weirdness?! :)
		mock.Setup(framework => framework.DownloadExists("2.0.0.0"))
			.Returns(true)
			.AtMostOnce();

		// Hand mock.Object as a collaborator and exercise it, 
		// like calling methods on it...
		ILoveThisFramework lovable = mock.Object;
		bool download = lovable.DownloadExists("2.0.0.0");

		// Verify that the given method was indeed called with the expected value
		mock.Verify(framework => framework.DownloadExists("2.0.0.0"));


[1]: http://code.google.com/p/moq/
[2]: http://code.google.com/p/moq/logo
[3]: http://www.nunit.org/index.php?p=docHome&r=2.6.2