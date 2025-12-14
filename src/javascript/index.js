import * as fs from "fs";

const files = fs.readFileSync("../../data/test_data.txt", 'utf-8');
console.log(files);

