(function() {
  var root;

  root = typeof exports !== "undefined" && exports !== null ? exports : this;

  root.TestingDemo = (function() {

    TestingDemo.name = 'TestingDemo';

    function TestingDemo() {}

    TestingDemo.prototype.fib = function(term) {
      if (typeof term === "undefined") {
        throw "A required parameter is missing";
      }
      if (term === 1 || term === 0) {
        return 1;
      } else {
        return fib(term - 1) + fib(term - 2);
      }
    };

    return TestingDemo;

  })();

}).call(this);
