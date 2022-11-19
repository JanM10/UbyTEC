import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListrepartidorComponent } from './listrepartidor.component';

describe('ListrepartidorComponent', () => {
  let component: ListrepartidorComponent;
  let fixture: ComponentFixture<ListrepartidorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListrepartidorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListrepartidorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
