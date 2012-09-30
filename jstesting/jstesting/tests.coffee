describe("WhenFibbing", () -> 
	it("ShouldFailWithUndefinedParameters", () -> 
		expect(()->
			demo = new TestingDemo();
			demo.fib();
		).toThrow("A required parameter is missing")
	)
	it("ShouldReturnCorrectlyForFirstTerm", () ->
		demo = new TestingDemo();
		result = demo.fib(1);
		expect(result).toEqual(1);
	)
);