import { TestBed } from '@angular/core/testing';

import { BookspaceService } from './bookspace.service';

describe('BookspaceService', () => {
  let service: BookspaceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BookspaceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
