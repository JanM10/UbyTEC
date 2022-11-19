import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListempleadoComponent } from './listempleado.component';

describe('ListempleadoComponent', () => {
  let component: ListempleadoComponent;
  let fixture: ComponentFixture<ListempleadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListempleadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListempleadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
