# ListView �ւ̃o�C���h�ƕύX�ʒm

ListView �� ItemsSource �ւ̃o�C���h�� INotifyCollectionChanged �C���^�[�t�F�[�X�����������R���N�V�������o�C���h����Ɨv�f�̒ǉ��폜�Ȃǂ̃R���N�V�����̕ύX�ɑΉ��\�ɂȂ�܂��B

���̗�ł́AMainPage.xaml.cs �� MainPageViewModel �� Items �v���p�e�B�� ObservableCollection �ł��B
����� MainPage.xaml �� ListView �� ItemsSource �Ƀo�C���h���Ă��܂��B����ŗv�f�̒ǉ����������Ƃ��i�폜�͎������Ă܂��񂪑Ή��\�ł��j�� ListView �̗v�f�������܂��B

�A�v�������s���� TextBox �ɉ�������� Add �{�^�����N���b�N����Ɗm�F�ł��܂��B

MainPageViewModel �� AddItemListItemCommand �Œǉ����������Ă��܂��B
Text �ɉ�������ĂȂ��Ɖ����Ȃ��悤�Ɏ������Ă��܂��B

# LsitView �̒��̃N���X�̃C���X�^���X�̃v���p�e�B�̕ύX�ʒm

����� ObservableCollection �Ɋi�[���ꂽ�I�u�W�F�N�g���ς�������Ƃ�ʒm����K�v������̂� ObservableCollection �̒��ɓ����Ă���N���X���̂� INotifyPropertyChanged ���������Ȃ���΂Ȃ�܂���B
����� ReactiveProperty ���g���ăv���p�e�B���g���ύX�ʒm����悤�ɂ��Ă��܂��B

ListItem �N���X�����̂悤�ɂȂ��Ă��܂��B

�A�v�����N������ TextBox �Ƀe�L�X�g����͂��� ListView �ŔC�ӂ̍s��I������� Set �{�^����������悤�ɂȂ�̂ŁA����œ���m�F�ł��܂��B

MainPageViewModel �N���X�� UpdateTextCommand �Ŏ������Ă��܂��B
UpdateTextCommand �̓e�L�X�g�ɉ��������Ă��� ListView �ŉ����I������Ă��Ȃ��Ɖ����Ȃ��悤�ɂ��Ă��܂��B
