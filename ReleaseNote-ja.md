# �����[�X�m�[�g

## v2.3

### �p�t�H�[�}���X

- ReactiveProperty�N���X�̃R���X�g���N�^�̏������\�����P���܂����B

### �ǉ�

- Xamarin.Mac�̃v���t�@�C����ǉ����܂���
- .NET Framework 4.6�̃o�C�i�����쐬���܂���

## v2.2.8

### �ύX

- ReactiveProperty��ReadOnlyReactiveProperty�̎����C���^�[�t�F�[�X��ύX���܂����B Issue #11.

## v2.2.7

### �ύX

- IFilteredReadOnlyObservableCollection�̓���������ύX

## v2.2.6

### �ǉ�

- ReactiveCollection�N���X��AddRangeOnScheduler���\�b�h��ǉ�.

## v2.2.5

### �X�V

- System.Windows.Interactivity�A�Z���u���ւ̎Q�Ƃ��X�V.

## v2.2.4

### �o�O�t�B�b�N�X

- FilteredReadOnlyObservableCollection�ɍ폜���̃C���f�b�N�X�Ǘ��̖����C��
- FilteredReadOnlyObservableCollection�ɒl�̓���ւ����̃C���f�b�N�X�Ǘ��̖����C��

## v2.2.3

### �o�O�t�B�b�N�X

- ReadOnlyReactiveCollection��Remove����Converter�����s����Ă��������C��

## v2.2.2

### �o�O�t�B�b�N�X

- FilteredReadOnlyObservableCollection�̏����������ŃC���f�b�N�X�̊Ǘ��ɖ�肪�������̂��C��

## v2.2.1

### �o�O�t�B�b�N�X

- ReadOnlyReactiveProperty�̃R���X�g���N�^�ŕ�����Subscribe���\�b�h���Ăяo���Ă����s����C�����܂����B

## v2.2

### �j��I�ύX

- ObserveElementReactiveProperty �g�����\�b�h���폜���܂����B

### Add

- ObserveElementObservableProperty �g�����\�b�h��ǉ����܂����B

## v2.1.8

### �ǉ�

- Helpers���O��ԂɃ��A���^�C���ɃR���N�V�����̗v�f���t�B���^�����O����R���N�V���� FilteredReadOnlyObservableCollection<T> ��ǉ����܂����B

## v2.1.7

### �o�O�t�B�b�N�X

- ReadOnlyReactiveProperty �� BehaviorSubject<T> ���\�[�X�ɍ�������� BehaviorSubject<T> ����ŏ��ɔ��s�����l�������l�Ƃ��Ďg���Ă��Ȃ������s����C�����܂����B

## v2.1.6

### �ǉ�

- ObservableCollection �� ReadOnlyObservableCollection �̗v�f�� ReactiveProperty �̕ύX���Ď����� ObserveElementReactiveProperty �g�����\�b�h���������܂����B
- ObservableCollection �� ReadOnlyObservableCollection �̗v�f�� PropertyChanged �C�x���g���Ď����� ObserveElementPropertyChanged �g�����\�b�h���������܂����B
- �ǂݎ���p�� ReactiveProperty �ł��� ReadOnlyReactiveProperty<T> ���������܂����BIObservable<T> ���� ToReadOnlyReactiveProperty �g�����\�b�h�Ő����ł��܂��B

### �j��I�ύX

- INotifyCollectionChanged �̊g�����\�b�h�Ƃ��Ē񋟂���Ă��� ObserveElementProperty ���\�b�h�̃A�N�Z�V�r���e�B�� internal �ɂ��܂����B

## v2.1.5

### �ǉ�

- IEnumerable����ReadOnlyReactiveCollection���쐬����g�����\�b�h��ǉ����܂����B

## v2.1.4

- ����

## v2.1.3

### �j��I�ύX

- ObserveElementProperty �Œl�ɕύX���������C���X�^���X���ʒm�ł���悤�ɂ��܂����B

## v2.1.2

### �ǉ�

- ObservableCollection �� ReadOnlyObservableCollection �̗v�f�̃v���p�e�B�ύX���Ď����� ObserveElementProperty �g�����\�b�h���������܂����B
- INotifyCollectionChanged �ɑ΂��� ObserveXxxChanged �g�����\�b�h��ǉ����܂����B

### �ύX

- ToReadOnlyReactiveCollection �g�����\�b�h����Q�ƌ^������������܂����B

## v2.1.1

### �ύX

- SynchronizationContext.Current �� null �̏ꍇ�� UIDispatcherScheduler ������������Ɣ��������O��ύX���܂����B 

## v2.1.0

### �ǉ�

- ReadOnlyReactiveCollection��ReadOnlyObservableCollection����쐬�ł���悤�ɂ��܂���
	- readOnlyObservableCollectionInstance.ToReadOnlyReactiveCollection(x => CreateViewModel(x))

### �ύX

- ReadOnlyReactiveCollection��Dispose���\�b�h���Ăяo�����Ƃ��ɁA�R���N�V���������̃C���X�^���X�ɑ΂��Ă�Dispose���ĂԂ悤�ɂ��܂���

## v2.0.1

### �ύX

- BooleanNotifier�N���X��INotifyPropertyChanged���������܂����B

## v2.0.0

### �j��I�ύX

- ���O��Ԃ� Codeplex.Reactive ���� Reactive.Bindings �ɕς��܂����B
- ReactiveProperty#ObserveHasError ���\�b�h��ObserveHasErrors�ɕύX���Ă��������B

### �񐄏�

- EventToReactive��񐄏��ɂ��܂����BEventToReactiveProperty��EventToReactiveCommand���g���Ă��������B

### �ύX�_

- ReadOnlyReactiveProperty���v�f���폜����Ƃ���Dispose���\�b�h���ĂԂ悤�ɂȂ�܂����B
- CountNotifier�N���X��INotifyPropertyChanged���������܂����B

### �ǉ�

- Xamarin.Android�p�̋@�\��ǉ����܂���
    - View�N���X��SetBinding�g�����\�b�h��ǉ����܂����B
    - IObservable<T>��SetCommand�g�����\�b�h��ǉ����܂����B
