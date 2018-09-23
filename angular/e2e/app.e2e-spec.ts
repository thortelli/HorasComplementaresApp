import { HorasComplementaresAppTemplatePage } from './app.po';

describe('HorasComplementaresApp App', function() {
  let page: HorasComplementaresAppTemplatePage;

  beforeEach(() => {
    page = new HorasComplementaresAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
