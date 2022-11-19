import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RConsolidadoVentasComponent } from './r-consolidado-ventas.component';

describe('RConsolidadoVentasComponent', () => {
  let component: RConsolidadoVentasComponent;
  let fixture: ComponentFixture<RConsolidadoVentasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RConsolidadoVentasComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RConsolidadoVentasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
