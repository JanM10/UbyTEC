import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddcomercioComponent } from './addcomercio.component';

describe('AddcomercioComponent', () => {
  let component: AddcomercioComponent;
  let fixture: ComponentFixture<AddcomercioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddcomercioComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddcomercioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
