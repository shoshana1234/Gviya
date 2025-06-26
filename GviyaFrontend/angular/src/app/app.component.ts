import { Component } from '@angular/core';
import { ResidentsService } from 'src/services/residents.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular';

  /**
   *
   */
  constructor(private residentsService: ResidentsService) {

  }

  public residentsList!: any;
  public columnNames=["residentId","idNumber","firstName","lastName","age"]
  ngOnInit() {
    this.residentsService.getResidents().subscribe(res => {
      this.residentsList = res;
    });
  }
}
