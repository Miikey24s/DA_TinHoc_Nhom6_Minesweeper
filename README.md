# 💣 Minesweeper - Dò Mìn

Trò chơi Dò Mìn (Minesweeper) phát triển bằng C# WinForms, đồ án môn Tin học cơ sở.

## Tính năng

- **3 cấp độ chơi**: Dễ, Trung bình, Khó (kích thước bàn cờ & số mìn khác nhau)
- **Cấp độ tuỳ chỉnh**: Tự chọn kích thước bàn cờ và số lượng mìn
- **Đăng ký / Đăng nhập**: Quản lý tài khoản người chơi
- **Lưu & tiếp tục game**: Lưu tiến trình chơi dở, load lại khi quay lại
- **Bảng xếp hạng**: Lưu điểm số theo tài khoản
- **Đếm thời gian**: Tính thời gian chơi từng ván
- **Cắm cờ**: Click phải để đánh dấu ô nghi ngờ có mìn

## Cấu trúc thư mục

```
├── Program.cs                  # Entry point
├── App.config
│
├── Forms/                      # Giao diện (WinForms)
│   ├── TrangChu.cs             # Màn hình chính
│   ├── DangKy_DangNhap.cs      # Đăng ký / Đăng nhập
│   ├── ChonCapDo.cs            # Chọn cấp độ & load game
│   └── PlayGame.cs             # Màn hình chơi game
│
├── Models/                     # Đối tượng dữ liệu
│   ├── Bom.cs                  # Quản lý số lượng bom
│   ├── User.cs                 # Tài khoản người dùng
│   ├── NutMinVaCo.cs           # Ô mìn (extends Button)
│   └── QuanLyCapDo.cs          # Cấu hình cấp độ
│
├── Services/                   # Logic xử lý
│   ├── GameLogic.cs            # Tạo bàn cờ, đặt mìn, đếm số
│   ├── DemThoiGianChoi.cs      # Timer đếm thời gian
│   ├── ThangThuaGame.cs        # Xử lý thắng/thua
│   ├── LuuTienTrinhGame.cs     # Lưu/load tiến trình game
│   └── FileHandler.cs          # Đọc/ghi file tài khoản
│
├── Controls/                   # Custom UI Controls
│   └── DoubleBufferedPanel.cs  # Panel chống nhấp nháy
│
├── Resources/                  # Hình ảnh
│   ├── bomb.png
│   ├── flag.png
│   └── icons8-back-32.png
│
└── Properties/                 # Assembly & Resources
```

## Yêu cầu

- **IDE**: Visual Studio 2019+ (hoặc 2022)
- **.NET Framework**: 4.7.2
- **OS**: Windows

## Cách chạy

1. Clone repo:
   ```bash
   git clone https://github.com/Miikey24s/DA_TinHoc_Nhom6_Minesweeper.git
   ```
2. Mở file `DA_TinHoc_Nhom6_Minesweeper.sln` bằng Visual Studio
3. Nhấn `Ctrl + F5` để build & chạy

## Tech Stack

- **Ngôn ngữ**: C#
- **Framework**: .NET Framework 4.7.2, Windows Forms
- **Lưu trữ**: File-based (text files)

## Nhóm phát triển

Đồ án Tin học — Nhóm 6
