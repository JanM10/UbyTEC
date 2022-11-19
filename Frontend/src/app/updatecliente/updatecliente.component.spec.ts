import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateclienteComponent } from './updatecliente.component';

describe('UpdateclienteComponent', () => {
  let component: UpdateclienteComponent;
  let fixture: ComponentFixture<UpdateclienteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateclienteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateclienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
