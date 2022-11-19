import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddafiliadoComponent } from './addafiliado.component';

describe('AddafiliadoComponent', () => {
  let component: AddafiliadoComponent;
  let fixture: ComponentFixture<AddafiliadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddafiliadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddafiliadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
