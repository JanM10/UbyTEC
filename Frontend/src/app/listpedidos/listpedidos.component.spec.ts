import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListpedidosComponent } from './listpedidos.component';

describe('ListpedidosComponent', () => {
  let component: ListpedidosComponent;
  let fixture: ComponentFixture<ListpedidosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListpedidosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListpedidosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
