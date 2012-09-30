(function() {

  describe("WhenFibbing", function() {
    it("ShouldFailWithUndefinedParameters", function() {
      return expect(function() {
        var demo;
        demo = new TestingDemo();
        return demo.fib();
      }).toThrow("A required parameter is missing");
    });
    return it("ShouldReturnCorrectlyForFirstTerm", function() {
      var demo, result;
      demo = new TestingDemo();
      result = demo.fib(1);
      return expect(result).toEqual(1);
    });
  });

}).call(this);
