import { Component, OnInit } from '@angular/core';
import { CheeseService } from 'src/app/services/cheese.service';

@Component({
  selector: 'app-cheese-list',
  templateUrl: './cheese-list.component.html',
  styleUrls: ['./cheese-list.component.css']
})
export class CheeseListComponent implements OnInit {

  cheeses: any;
  currentTutorial = null;
  currentIndex = -1;
  title = '';

  constructor(private cheeseService: CheeseService) { }

  ngOnInit(): void {
    console.log('init');
    this.retrieve();
    console.log('finished');
    console.log(this.cheeses);
  }

  retrieve(): void {
    this.cheeseService.getAll()
      .subscribe(
        data => {
          this.cheeses = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
}
