import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookspaceComponent } from './bookspace.component';

describe('BookspaceComponent', () => {
  let component: BookspaceComponent;
  let fixture: ComponentFixture<BookspaceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookspaceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BookspaceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
