root = exports ? this
class root.TestingDemo
	fib: (term) -> 
		if(typeof term == "undefined")
			throw "A required parameter is missing"
		if(term == 1 || term == 0)
			return 1
		else 
			return fib(term-1) + fib(term-2)
