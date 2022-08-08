//import Papa from 'papaparse';
import CreatePrize from "./CreatePrize.js";

const tableRoot = document.querySelector("#csvRoot");  //table Id from index file
//const csvFileInput = document.querySelector("#csvFileInput");
//Open csv file
//$file =fgetcsv('/Tournament-Tracker/dataFiles/TournamentModels.csv', "r")
//const csvFileInput = '/Tournament-Tracker/dataFiles/TournamentModels.csv'
const createPrize = new CreatePrize(tableRoot);



csvFileInput.addEventListener("change", e => {
window.onload = () => {

}
    console.log(csvFileInput.files[0]);

    Papa.parse(csvFileInput.files[0], {
        delimiter: ",",
        skipEmptyLines: true,
        complete: results =>{
            createPrize.update(results.data.slice(0), results.data[0]);
        }
    })
});



