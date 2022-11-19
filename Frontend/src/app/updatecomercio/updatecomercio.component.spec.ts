import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatecomercioComponent } from './updatecomercio.component';

describe('UpdatecomercioComponent', () => {
  let component: UpdatecomercioComponent;
  let fixture: ComponentFixture<UpdatecomercioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdatecomercioComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdatecomercioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
