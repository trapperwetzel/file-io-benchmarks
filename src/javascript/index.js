import * as fs from "fs";

const readFiles = () => {

  const files = fs.readFileSync("../../data/test_data.txt", 'utf-8');
  console.log(files);


}
readFiles();

