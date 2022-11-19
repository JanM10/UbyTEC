import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddrepartidorComponent } from './addrepartidor.component';

describe('AddrepartidorComponent', () => {
  let component: AddrepartidorComponent;
  let fixture: ComponentFixture<AddrepartidorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddrepartidorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddrepartidorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
