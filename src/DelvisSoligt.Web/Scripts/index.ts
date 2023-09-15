import $ from "jquery";
import _ from "lodash";

console.log("hello from esbuild");

var linkLength = $("a").length;
console.log(`${linkLength} + 1 = ${_.add(linkLength, 1)}`);

type Item = {
  id: number;
  name: string;
};

type Items = Item[];

var items = <Items>[
  {
    id: 1,
    name: "item-1",
  },
  {
    id: 2,
    name: "item-2",
  },
];

for (const item of items) {
  console.log(`Id: ${item.id}\nName: ${item.name}`);
}
