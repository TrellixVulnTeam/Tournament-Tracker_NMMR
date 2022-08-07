export default class{
    /** 
     * @param {HTMLTableElement} root The table element which will display CSV data.
     */
    constructor(root){
        this.root = root;
    }

    /** 
     * Clears existing table data and replaces with new data
     * @param {string[][]} data The table element which will display CSV data.
     * @param {string[]} headerColumns List of headings to be used.
     */
    update(data, headerColumns = []){
        this.clear();
        //this.setHeader(headerColumns);
        this.setBody(data);
    }
    /**
     * Clears all contents of the table (incl. the header)
     */
    clear() {
        this.root.innerHTML = "";
    }
    /**
     * Sets the table Header
     * @param {string[]} headerColumns List of headings to be used.
     */
    setHeader(headerColumns){
        this.root.insertAdjacentHTML("afterbegin",`
            <thead>
                <tr>
                    ${headerColumns.map(text => `<th>${text}</th>`).join("") }
                </tr>
            </thead>
        `);
    }
     /**
     * Sets the table body
     * @param {string[][]} data A 2D array of data to be used as the table body.
     */
    setBody(data) {
        const rowsHtml = data.map(row => {
            return`
                <tr>
                    ${ row.map(text => `<td>${ text }</td>`).join("") }
                </tr>
            `;
        });

        this.root.insertAdjacentHTML("beforeend", `
            <tbody>
                ${ rowsHtml.join("")}
            </tbody>                
        `);
    }    
}