import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/_services/car.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { Car } from 'src/app/_models/car';

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.css']
})
export class CarListComponent implements OnInit {
cars: Car[];
  constructor(private carService: CarService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadCars();
  }

  loadCars() {
    this.carService.getCars().subscribe((cars: Car[]) => {
      this.cars = cars;
    }, error => {
      this.alertify.error(error);
    });
  }
}
