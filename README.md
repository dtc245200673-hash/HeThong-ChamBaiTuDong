# Hệ thống Nộp bài và Chấm bài Tự động (Đề tài 15)

Hệ thống phân tán xây dựng trên nền tảng **.NET 10 (ASP.NET Core Minimal API)**, **RabbitMQ**, **SignalR**, **PostgreSQL** và **Docker Compose**.

## Kiến trúc hệ thống

```text
Student Client -> Submission API -> RabbitMQ -> Grading Worker -> RabbitMQ -> Notification Service -> Client
                         |                           |
                         +------> Database <---------+
