jasmine.createChainedSpyObj = function (name, functions) {
	if (!name || name == "")
		throw "The name of the spy object is required.";
	if (!functions || !functions.length || functions.length == 0)
		throw "The list of functions is required.";

	var obj = {};
	for (var i = 0; i < functions.length; i++) {
		obj[functions[i]] = function () { };
		spyOn(obj, functions[i]).andReturn(obj);
	}
	return obj;
}