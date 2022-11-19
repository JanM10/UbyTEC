import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleterepartidorComponent } from './deleterepartidor.component';

describe('DeleterepartidorComponent', () => {
  let component: DeleterepartidorComponent;
  let fixture: ComponentFixture<DeleterepartidorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleterepartidorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleterepartidorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
