﻿/// <reference path="jquery-2.0.3.js" />
/// <reference path="class.js" />

var controls = controls || {};
(function (c) {
	var TableView = Class.create({
		init: function (itemsSource, rows, cols) {
			if (!(itemsSource instanceof Array)) {
				throw "The itemsSource of a ListView must be an array!";
			}
			this.itemsSource = itemsSource;
			this.rows = rows;
			this.cols = cols;
		},
		render: function (template) {
		    var table = document.createElement("table");
		    var count = 0;
			for (var row = 0; row < this.rows; row++) {
			    var rowItem = document.createElement("tr");
			    for (var col = 0; col < this.cols; col++, count++) {
			        var cellItem = document.createElement("td");
			        if (count < this.itemsSource.length) {
			            var item = this.itemsSource[count];
			            cellItem.innerHTML = template(item);
			            rowItem.appendChild(cellItem);
			        }
			    }
			    table.appendChild(rowItem);
			}
			return table.outerHTML;
		}
	});

	c.getTableView = function (itemsSource, rows, cols) {
	    return new TableView(itemsSource, rows, cols);
	}
}(controls || {}));