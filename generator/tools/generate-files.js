const sfdxGenerator = require('../compiled/sfdx-generator.js');
const path = require('path');
const root = path.resolve(__dirname, './');
const generator = new sfdxGenerator.Generator({
  SFDXPath: 'sfdx',
  outputDirectory: path.resolve(root, '../../src/Client/Commands/Generated'),
  templateDirectory: path.resolve(root, './classTemplates'),
  fileExtension: '.cs',
  formatFileName: (defaultFileName) => {
    return defaultFileName.charAt(0).toUpperCase() + defaultFileName.slice(1);
  }
});

const commandFile = require('../commands.json');
const stringFile = JSON.stringify(commandFile);
generator.generate(stringFile).then(() => {
  console.log('Generating done');
});