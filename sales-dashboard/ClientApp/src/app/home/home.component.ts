import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  years: KeyValue[];
  months: KeyValue[] = [
    { key: 1, value: "January" },
    { key: 2, value: "February" },
    { key: 3, value: "March" },
    { key: 4, value: "April" },
    { key: 5, value: "May" },
    { key: 6, value: "June" },
    { key: 7, value: "July" },
    { key: 8, value: "August" },
    { key: 9, value: "September" },
    { key: 10, value: "October" },
    { key: 11, value: "November" },
    { key: 12, value: "December" },
  ];

  public barChart = {
    chartType: 'Bar',
    dataTable: [
      ['Month', '2018', '2017' ],
      ['Jan', 1000, 400 ],
      ['Feb', 1170, 460 ],
      ['Mar', 660, 1120 ],
      ['Apr', 1030, 540 ],
      ['May', 1234, 999 ],
      ['Jun', 450, 600  ]
    ],
    options: {
      chart: {
        title: 'Company Performance',
        subtitle: 'Sales Report'
      },
      height: 350
    }
  };

  constructor() {
    var currentYear = (new Date()).getFullYear();
    this.years = [];
    this.years.push({ key: currentYear, value: currentYear.toString() })
    this.years.push({ key: (currentYear - 1), value: (currentYear - 1).toString() })
    this.years.push({ key: (currentYear - 2), value: (currentYear - 2).toString() })
  }
}

export interface KeyValue {
  key: any;
  value: string;
}