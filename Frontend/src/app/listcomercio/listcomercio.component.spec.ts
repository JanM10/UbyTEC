import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListcomercioComponent } from './listcomercio.component';

describe('ListcomercioComponent', () => {
  let component: ListcomercioComponent;
  let fixture: ComponentFixture<ListcomercioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListcomercioComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListcomercioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
