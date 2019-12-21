/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { RentedCarListComponent } from './rented-car-list.component';

describe('RentedCarListComponent', () => {
  let component: RentedCarListComponent;
  let fixture: ComponentFixture<RentedCarListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RentedCarListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RentedCarListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
