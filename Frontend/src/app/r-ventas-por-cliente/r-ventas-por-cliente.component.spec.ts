import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RVentasPorClienteComponent } from './r-ventas-por-cliente.component';

describe('RVentasPorClienteComponent', () => {
  let component: RVentasPorClienteComponent;
  let fixture: ComponentFixture<RVentasPorClienteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RVentasPorClienteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RVentasPorClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
