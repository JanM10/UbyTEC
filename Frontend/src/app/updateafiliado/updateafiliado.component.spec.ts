import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateafiliadoComponent } from './updateafiliado.component';

describe('UpdateafiliadoComponent', () => {
  let component: UpdateafiliadoComponent;
  let fixture: ComponentFixture<UpdateafiliadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateafiliadoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateafiliadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
