import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListafiliadoComponent } from './listafiliado.component';

describe('ListafiliadoComponent', () => {
  let component: ListafiliadoComponent;
  let fixture: ComponentFixture<ListafiliadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListafiliadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListafiliadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
