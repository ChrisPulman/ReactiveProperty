# Xamarin.Forms��ReactiveProperty���C���X�g�[��������@

## �菇1. �v���W�F�N�g�̍쐬
Blank App (Xamarin.Forms Portable)���쐬���܂�.

## �菇2. Windows��WinPhone�v���W�F�N�g�̍폜
ReactiveProeprty 3.0��Windows 8.1��Windows Phone 8.1���T�|�[�g���܂���B
Windows��WinPhone�v���W�F�N�g���\�����[�V��������폜���܂��B

![Remove project](Images/removewinandwpproject.PNG)

## �菇3. .NET Standard�ւ̃A�b�v�O���[�h
�|�[�^�u���N���X���C�u�����̃v���W�F�N�g���炷�ׂĂ�nuget�p�b�P�[�W���폜���܂��B

![Remove nuget reference](Images/removenugetpackage.png)

## .NET Standard(���Ȃ��Ă����C)
�|�[�^�u���N���X���C�u�����̃v���W�F�N�g�̃v���p�e�B�y�[�W���J���܂��B
�����āA`���C�u����`�^�u��`Target .NET Platform Standard`���N���b�N���܂��B

![Remove nuget reference](Images/targetnetplatformstandard.png)

�����āA.NET Standard 1.2�ɕύX���܂��B

project.json��improts��ǉ����܂��B

```javascript
{
  "supports": {},
  "dependencies": {
    "Microsoft.NETCore.Portable.Compatibility": "1.0.1",
    "NETStandard.Library": "1.6.0"
  },
  "frameworks": {
    "netstandard1.2": {
      "imports": "portable-uap+net45"
    }
  }
}
```
## �菇4. Micfosoft.NETCore.UniversalWindowsPlatform�̍X�V

�\�����[�V������NuGet�p�b�P�[�W�}�l�[�W���[���J����Microsoft.NETCore.UniversalWindowsPlatform�p�b�P�[�W��v5.2.2(�������͂���ȏ�)�ɍX�V���܂��B

## �菇5. Xamarin.Forms�̍X�V

���ׂẴv���W�F�N�g��Xamarin.Forms���ŐV�̈���łɍX�V���܂��B

![Upgrade XF](Images/upgradexf.png)

## �菇6. ���ׂẴv���W�F�N�g��ReactiveProperty���C���X�g�[��

ReactiveProeprty v3.x��NuGet����C���X�g�[�����܂��B

![Install RP](Images/installrp.PNG)

## �菇7. Droid�v���W�F�N�g����Q�Ƃ��폜

`System.Runtime.InteropService.WindowsRuntime`�̎Q�Ƃ�Droid�v���W�F�N�g����폜���܂��B�i�d�v�j

## �菇8. �R�[�h�������܂��傤

�C���X�g�[�������������̂ŁAReactiveProperty���g�����R�[�h�������܂��傤�I