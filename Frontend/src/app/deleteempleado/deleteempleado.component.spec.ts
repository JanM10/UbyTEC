import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteempleadoComponent } from './deleteempleado.component';

describe('DeleteempleadoComponent', () => {
  let component: DeleteempleadoComponent;
  let fixture: ComponentFixture<DeleteempleadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteempleadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleteempleadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
