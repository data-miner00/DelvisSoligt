import $ from "jquery";
import _ from "lodash";

console.log("hello from esbuild");

var linkLength = $("a").length;
console.log(`${linkLength} + 1 = ${_.add(linkLength, 1)}`);
