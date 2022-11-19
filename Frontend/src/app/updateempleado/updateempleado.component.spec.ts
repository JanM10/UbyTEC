import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateempleadoComponent } from './updateempleado.component';

describe('UpdateempleadoComponent', () => {
  let component: UpdateempleadoComponent;
  let fixture: ComponentFixture<UpdateempleadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateempleadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateempleadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
