finishSuite = () ->
	phantom.exit();	

page = require('webpage').create();
phantom.injectJs "Jasmine/jasmine.js"
phantom.injectJs "Jasmine/jasmine-console.js"

phantom.injectJs "functionality.js"

phantom.injectJs "tests.js"

setTimeout finishSuite, 1000
jasmineEnv = jasmine.getEnv();
jasmineEnv.updateInterval = 1000;
consoleReporter = new jasmine.ConsoleReporter();
jasmineEnv.addReporter(consoleReporter);

jasmineEnv.execute();