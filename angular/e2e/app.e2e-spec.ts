import { C10TemplatePage } from './app.po';

describe('C10 App', function () {
    let page: C10TemplatePage;

    beforeEach(() => {
        page = new C10TemplatePage();
    });

    it('should display message saying app works', () => {
        page.navigateTo();
        expect(page.getParagraphText()).toEqual('app works!');
    });
});
