//test.js, JavaScript函数库, 德鲁泰科技2016
function testLiteralObject() {
    person = { xing: "张", ming: "三" };
    person.dz = "济南";
    person["zy"] = "程序员";
    console.log("zy", person.zy, "xing", person.xing, "ming", person["ming"], "dz", person["dz"]);
    for (var prop in person) {
        console.log(prop, person[prop]);
    }
}
function testSplit() {
    var qvars = window.location.search.substr(1).split('&');
    for (var i = 0; i < qvars.length; i++) {
        console.log(qvars[i]);
    }
}